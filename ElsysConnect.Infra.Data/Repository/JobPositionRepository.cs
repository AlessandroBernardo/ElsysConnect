using Dapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using Infra.Data.ContextDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Infra.Data.Repository
{
    public class JobPositionRepository : BaseRepository<JobPosition>, IJobPositionRepository
    {
        public JobPositionRepository(IDbConnection dbConnection) : base(dbConnection)
        {

        }
    }

}

