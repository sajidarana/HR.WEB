
using HR.DATA.Data;
using HR.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace HR.DAL
{
    public class CatalogDAL
    {
        private readonly test1Context _context;

        public CatalogDAL(test1Context context)
        {
            _context = context;
        }
        public async Task<List<Tbldiscipline>> GetDecipline()
        {
            List<Tbldiscipline> level = new List<Tbldiscipline>();
            level = await _context.Tbldisciplines.ToListAsync();
            level.Insert(0, new Tbldiscipline { DisciplineId = 0, Name = "Select" });
            return level;
        }
        public List<Tbloccupation> GetoccupatiosByDisciplineId(int id)
        {
            List<Tbloccupation> occupationList = new List<Tbloccupation>();

            return occupationList = (from occupationid in _context.Tbloccupations
                              where occupationid.DisciplineId == id
                              select occupationid).ToList();
        }
        public List<Tblspeciality> GetspecialitiesByOccupationId(int id)
        {
            List<Tblspeciality> occupationList = new List<Tblspeciality>();

            return occupationList = (from specialityId in _context.Tblspecialities
                                     where specialityId.OccupationId == id
                                     select specialityId).ToList();
        }
    }
}
