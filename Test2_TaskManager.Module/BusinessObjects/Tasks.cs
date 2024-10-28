using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_TaskManager.Module.BusinessObjects
{
    // Coloca un elemento de navegación para esta clase en el grupo "Task Management".
    [NavigationItem("Task Management")]
    // Hereda de BaseObject para soportar operaciones CRUD automáticamente.
    public class Tasks : BaseObject
    {
        public virtual string Descripcion { get; set; }

        public virtual bool EstaCompleta { get; set; }

        // Limita el tamaño del campo de texto.
        [FieldSize(255)]
        public virtual string Notas { get; set; }

        // Oculta esta propiedad en la vista de lista.
        [VisibleInListView(false)]
        public virtual DateTime FechaCreacion { get; set; }

        public Tasks() => FechaCreacion = DateTime.Now;
    }
}
