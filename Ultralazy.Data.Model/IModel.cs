using System;


namespace Ultralazy.Data.Model
{
    /// <summary>
    /// Base Interface Id, CreatedBy, ModifiedBy, CreatedDate & ModifiedDate
    /// </summary>
    public interface IModel
    {
        int Id { get; set; }
        int CreatedBy { get; set; }
        int ModifiedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
