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

        public void AddChallenge(Challenge challenge)
        {
            throw new NotImplementedException();
        }

        public List<Challenge> GetByLevelId(int id)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                          SELECT [Name], levelId, attempts, description, urlLink
                            FROM Challenge
                           WHERE LevelId = @Id";

                    DbUtils.AddParameter(cmd, "@Id", id);

                    var reader = cmd.ExecuteReader();

                    List<Challenge> challenges = new List<Challenge>();
                    while (reader.Read())
                    {
                        Challenge challenge = new Challenge()
                        {
                            Id = id,
                            LevelId = DbUtils.GetInt(reader, "LevelId"),
                            Name = DbUtils.GetString(reader, "Name"),
                            Attempts = DbUtils.GetInt(reader, "Attempts"),
                            Description = DbUtils.GetString(reader, "Description"),
                            UrlLink = DbUtils.GetString(reader, "UrlLink")
                        };
                        challenges.Add(challenge);
                    }

                    reader.Close();

                    return challenges;
                }
            }
        }
    }
}

