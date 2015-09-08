using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordFrequency
{
    public class ParserConcurrentDict
    {
        ConcurrentDictionary<string, int> m_Count;
        readonly string[] m_arr;

        public ConcurrentDictionary<string, int> Count { get { return m_Count; } }
        public string[] Arr { get { return m_arr;  } }

        public ParserConcurrentDict(string text) {
            m_arr = text.ToLowerInvariant().Split(new char[] { ' ', '\r', '\n', '\t' },StringSplitOptions.RemoveEmptyEntries);
            m_Count = new ConcurrentDictionary<string, int>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskCnt">Ile tasków uruchomić</param>
        public void StartProcessing(int taskCnt) {
            if (taskCnt < 1) throw new ArgumentException();
            int taskSize = m_arr.Length / taskCnt;
            int lastTaskSize = m_arr.Length - (taskSize * (taskCnt - 1));
            Task[] t = new Task[taskCnt];
            for (int i = 0; i < taskCnt - 1; i++) {
                int from = i * taskSize;
                t[i] = Task.Run(() => DoScan(from, taskSize));
            }
            t[taskCnt-1] = Task.Run(() => DoScan((taskCnt - 1) * taskSize, lastTaskSize));
            Task.WaitAll(t);
        }
        public void DoScan(int start, int length) {
            if (length<0 || start < 0) throw new ArgumentException();
            if ((start + length) > m_arr.Length) throw new ArgumentException();
            string key;
            int cnt;
            for (int i = start; i < start + length; i++) {
                key = m_arr[i];
                Trace.WriteLine(Task.CurrentId + ", " + key);
                if (!m_Count.TryGetValue(key, out cnt)) {
                    if (!m_Count.TryAdd(key, 1)) {
                        updateKey(key, 2);
                    }
                } else {
                    updateKey(key, cnt+1);
                }
            }
        }

        private void updateKey(string key, int cnt) {
            while (!m_Count.TryUpdate(key, cnt + 1, cnt)) {
                m_Count.TryGetValue(key, out cnt);
            }
        }
    }
}
