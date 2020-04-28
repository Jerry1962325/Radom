using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reader.MTableAdapters;
using static Reader.M;
using System.Data;
using Reader;

namespace Reader
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
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool ADD(string name, string stars, string date, string country, string types,string review)
        {
            //新行
            M.MoviesDataTable movies = new MoviesDataTable();
            M.MoviesRow row = movies.NewMoviesRow();
            row.Name = name;
            row.Stars = stars;
            row.Date = date;
            row.Country = country;
            row.Types = types;
            row.Review = review;
            row.Bool = true;
            //加入
            movies.AddMoviesRow(row);
            int ed = Adapter.Update(movies);
            return ed == 1;
        }
    }
}
