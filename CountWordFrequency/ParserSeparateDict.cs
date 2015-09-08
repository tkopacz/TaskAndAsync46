using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordFrequency {
    public class ParserSeparateDict {
        Dictionary<string, int> m_Count;
        readonly string[] m_arr;

        public Dictionary<string, int> Count { get { return m_Count; } }
        public string[] Arr { get { return m_arr; } }

        public ParserSeparateDict(string text) {
            m_arr = text.ToLowerInvariant().Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            m_Count = new Dictionary<string, int>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskCnt">Ile tasków uruchomić</param>
        public void Process(int taskCnt) {
            if (taskCnt < 1) throw new ArgumentException();
            int taskSize = m_arr.Length / taskCnt;
            int lastTaskSize = m_arr.Length - (taskSize * (taskCnt - 1));
            Task[] t = new Task[taskCnt];
            for (int i = 0; i < taskCnt - 1; i++) {
                //4.0 - i tu złośliwy bład z i przy okazji - omówić!!
                //t[i] = Task.Factory.StartNew(() => DoScan(i * taskSize, taskSize));
                //Od 4.5
                int from = i * taskSize;
                t[i] = Task.Run(() => DoScan(from, taskSize));
            }
            t[taskCnt - 1] = Task.Run(() => DoScan((taskCnt - 1) * taskSize, lastTaskSize));
            Task.WaitAll(t);
        }
        public void DoScan(int start, int length) {
            if (length < 0 || start < 0) throw new ArgumentException();
            if ((start + length) > m_arr.Length) throw new ArgumentException();
            string key;
            var count = new Dictionary<string, int>();
            for (int i = start; i < start + length; i++) {
                key = m_arr[i];
                if (count.Keys.Contains(key))
                    count[key]++;
                else
                    count.Add(key, 1);
            }
            lock(m_Count ) {
                foreach (var item in count) {
                    if (m_Count.Keys.Contains(item.Key))
                        m_Count[item.Key] += item.Value; 
                    else
                        m_Count.Add(item.Key, item.Value);
                }
            }
        }

    }
}
