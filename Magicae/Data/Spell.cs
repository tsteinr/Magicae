using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magicae.Data
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Spells")]
    public class Spell
    {
        /// <summary>
        /// 
        /// </summary>
        [Key, Column("ID")]
        public int Id { get; set; }
    }
}
