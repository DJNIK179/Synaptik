//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Синаптик
{
    using System;
    using System.Collections.Generic;
    
    public partial class Development
    {
        public int Id { get; set; }
        public Nullable<int> IdClent { get; set; }
        public Nullable<int> IdEmployees { get; set; }
        public Nullable<int> IdSites { get; set; }
        public Nullable<int> Prise { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Sites Sites { get; set; }
    }
}
