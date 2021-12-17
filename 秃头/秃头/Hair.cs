using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秃头
{
    public class Hair
    {
        private String m_losstime;
        public String LossTime
        {
            get { return m_losstime; }
        }

        public Hair()
        {

        }

        public Hair(String _losstime)
        {
            m_losstime = _losstime;
        }

        public override String ToString()
        {
            return m_losstime;
        }
    }
}
