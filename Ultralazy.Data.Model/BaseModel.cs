using System;
using ServiceStack.DataAnnotations;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Ultralazy.Data.Model
{
    /// <summary>
    /// Mark System.Runtime.Serialization.DataContract.DataContract for class BaseModel & Id as Primarykey with autoincrement enabled
    /// </summary>
    [DataContract]
    public abstract class BaseModel : IModel
    {
        [DataMember(Order = 1)]
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }

        [IgnoreDataMember]
        public int CreatedBy { get; set; }

        [IgnoreDataMember]
        public int ModifiedBy { get; set; }

        [IgnoreDataMember]
        public virtual DateTime CreatedDate { get; set; }

        [IgnoreDataMember]
        public DateTime ModifiedDate { get; set; }
    }
}
