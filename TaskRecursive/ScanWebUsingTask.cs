using CountWordFrequency;
using HTMLUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRecursive
{
    public class ScanWebUsingTask
    {
        Dictionary<string, Dictionary<string, int>> m_result=new Dictionary<string, Dictionary<string, int>>();

        public ScanWebUsingTask() {

        }
        public async Task<int> Scan(string startURL, int depth,int taskCnt = 4) {
            TextInHTML t = new TextInHTML();
            var result = await t.Process(startURL);
            ParserSeparateDict p = new ParserSeparateDict(result.Text);
            p.Process(taskCnt);
            lock (m_result) {
                m_result.Add(startURL, p.Count);
            }
            int count = 1;
            if (depth>0) {
                foreach (var item in result.Links) {
                    if (!m_result.ContainsKey(item)) {
                        count += await Scan(item, depth - 1);
                    }
                }
                //A to oczywiście nie zadziała
                //Parallel.ForEach(result.Links, async item => {
                //    count += await Scan(item, depth - 1);
                //});
                //Inne podejście- albo async albo Parallel.ForEach
                //Może DataFlow?
            }
            return count;
        }

    }
}
