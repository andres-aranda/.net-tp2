using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int _Id;
        private Business.Entities.BusinessEntity.State _Estado;
        public enum State
        {
            Deleted, 
            New, 
            Modified, 
            Unmodified
        } 

        public int Id
        {
            get => default;
            set
            {
            }
        }

        public State Estado
        {
            get => default;
            set
            {
            }
        }
    }
}
