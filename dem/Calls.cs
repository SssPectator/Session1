//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calls
    {
        public int ID_Call { get; set; }
        public Nullable<int> NumCall { get; set; }
        public string zDataTime { get; set; }
        public Nullable<int> Duration { get; set; }
        public string InOut { get; set; }
        public Nullable<int> User_ID { get; set; }
    
        public virtual Users Users { get; set; }
    }
}