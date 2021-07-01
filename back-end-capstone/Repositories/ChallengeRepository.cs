using back_end_capstone.Models;
using back_end_capstone.Utils;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_capstone.Repositories
{
    public class ChallengeRepository : BaseRepository, IChallengeRepository
    {
        public ChallengeRepository(IConfiguration config) : base(config) { }

        public Challenge GetByLevelId(int id)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                          SELECT 
                            FROM Challenge
                           WHERE LevelId = @Id";

                    DbUtils.AddParameter(cmd, "@Id", id);

                    var reader = cmd.ExecuteReader();

                    Category category = null;
                    if (reader.Read())
                    {
                        category = new Category()
                        {
                            Id = id,
                            Name = DbUtils.GetString(reader, "Name"),
                        };
                    }

                    reader.Close();

                    return category;
                }
            }
        }
    }
}

