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
        private Business.Entities.BusinessEntity.Estados _State;
        public enum Estados
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

        public Estados State
        {
            get => default;
            set
            {
            }
        }
    }
}
