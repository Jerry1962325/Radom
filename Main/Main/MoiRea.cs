using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.MTableAdapters;
using static Main.M;
using System.Data;
using System.Windows.Forms;

namespace Main
{
    [System.ComponentModel.DataObject]
    public class MoiRea
    {
        //初始化
        private MoviesTableAdapter TA = null;
        protected MoviesTableAdapter Adapter
        {
            get
            {
                if (TA == null) TA = new MoviesTableAdapter();
                return TA;
            }
        }
        //byID
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select,true)]
        public M.MoviesDataTable GetMovie(string types)
        {
            Random rd = new Random();
            string[] type;
            M.MoviesRow row;
            M.MoviesDataTable movie;
            while (true)
            {
                int ID = rd.Next(2, 252);
                movie = Adapter.GetDataByID(ID);
                row = movie[0];
                type = row.Types.Split(' ');
                foreach (string i in type)
                {
                    if (i == types && row.Bool) { goto re; }
                }
            }
         re:
            return movie;
        }
    }
}