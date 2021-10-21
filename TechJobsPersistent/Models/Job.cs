﻿using System;
using System.Collections.Generic;

namespace TechJobsPersistent.Models
{
    public class Job
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employer Employer { get; set; }

        public int EmployerId { get; set; }

        public List<JobSkill> JobSkills { get; set; }

        public Job()
        {
        }

        public Job(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(Employer, job.Employer) &&
                   EmployerId == job.EmployerId &&
                   EqualityComparer<List<JobSkill>>.Default.Equals(JobSkills, job.JobSkills);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Employer, EmployerId, JobSkills);
        }
    }
}
