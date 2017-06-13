using SportsClub.Model;
using SportsClub.DataLayer;
using System.Collections.Generic;
using System.Data;
using System;

namespace SportsClub.BusinessLayer
{
    public class SportBL
    {
        public IEnumerable<Sport> GetSportsList()
        {
            SportDL dl = new SportDL();
            DataTable sportsTbl = dl.GetSportsList();

            List<Sport> SportsList = new List<Sport>();
            foreach (DataRow row in sportsTbl.Rows)
            {
                SportsList.Add(new Sport()
                {
                    CId = Convert.ToInt32(row["CId"]),
                    ContinentName = row["ContinentName"].ToString(),
                    SportName = row["SportName"].ToString(),
                    Description = row["Description"].ToString(),
                    ImageUrl = row["ImageUrl"].ToString()
                });
            }

            return SportsList;
        }

        public IEnumerable<Sport> GetSports(string Continent)
        {
            SportDL dl = new SportDL();
            DataTable sportsTbl = dl.GetSportsList(Continent);
            IList<Sport> list = new List<Sport>();
            if (sportsTbl.Rows.Count > 0) {
                for (int i = 0; i < sportsTbl.Rows.Count; i++)
                {
                    list.Add(new Sport()
                    {
                        CId = Convert.ToInt32(sportsTbl.Rows[i]["CId"]),
                        ContinentName = sportsTbl.Rows[i]["ContinentName"].ToString(),
                        SportName = sportsTbl.Rows[i]["SportName"].ToString(),
                        Description = sportsTbl.Rows[i]["Description"].ToString(),
                        ImageUrl = sportsTbl.Rows[i]["ImageUrl"].ToString()
                    });
                }
               
                return list;
            }
            return null;
        }
    }
}
