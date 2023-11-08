using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.Models
{
    class USERINFO
    {
        private string username;
        private int userage;
        private string userimg;

        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }

        public string USERIMG
        {
            get { return userimg; }
            set { userimg = value; }
        }

        public int USERAGE
        {
            get { return userage; }
            set { userage = value; }
        }


    }
}
