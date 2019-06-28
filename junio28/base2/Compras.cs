namespace junio28.base2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Compras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompraId { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Producto { get; set; }

        public int? Cantidad { get; set; }

        public int? PrecioUnitario { get; set; }

        public int? UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
