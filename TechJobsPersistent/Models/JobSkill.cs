using System;
using System.Collections.Generic;

namespace TechJobsPersistent.Models
{
    public class JobSkill
    {
        public int JobId { get; set; }
        public Job Job { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public JobSkill()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is JobSkill skill &&
                   JobId == skill.JobId &&
                   EqualityComparer<Job>.Default.Equals(Job, skill.Job) &&
                   SkillId == skill.SkillId &&
                   EqualityComparer<Skill>.Default.Equals(Skill, skill.Skill);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(JobId, Job, SkillId, Skill);
        }
    }
}