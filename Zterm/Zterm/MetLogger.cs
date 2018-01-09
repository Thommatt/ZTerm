using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Zterm
{
    class MetLogger
    {
        public MetLogger()
        {

        }

        public void do_logger(string s)
        {
            log_string(s);
        }

        public void do_logger(char c)
        {
            log_char(c);
        }

        private void log_string(string s)
        {
            string filePath = DateTime.Now.ToString("yyyy_MM_dd") + "_" + Zterm.Properties.Settings.Default.LogSavePath;
            string d = Path.GetDirectoryName(Zterm.Properties.Settings.Default.LogSavePath);

            if (!Directory.Exists(d))
            {
                Directory.CreateDirectory(d);
                Thread.Sleep(100);
            }
                

            if (!string.IsNullOrEmpty(filePath))
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(s);
                }
            }
        }

        private void log_char(char c)
        {
            string filePath = Zterm.Properties.Settings.Default.LogSavePath;
            string fileName = Path.GetFileName(filePath);
            string d = Path.GetDirectoryName(Zterm.Properties.Settings.Default.LogSavePath);
            filePath = Path.Combine(d, DateTime.Now.ToString("yyyy_MM_dd") + "_" + fileName);

            if (!Directory.Exists(d))
            {
                Directory.CreateDirectory(d);
                Thread.Sleep(100);
            }

            if (!string.IsNullOrEmpty(filePath))
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.Write(c);
                }
            }
        }
    }
}
