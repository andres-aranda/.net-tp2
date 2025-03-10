﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;

namespace Business.Logic
{
  public  class PlanLogic:BusinessLogic
    {
        public PlanAdapter PlanData { get; set; }

        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }

        public Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public void Save(Plan u)
        {
            PlanData.Save(u);
        }

        public void Delete(int id)
        {
            PlanData.Delete(id);
        }
    }
}
