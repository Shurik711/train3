//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace train3
{
    using System;
    using System.Collections.Generic;
    
    public partial class SOTRUDNIKI
    {
        public int IDS { get; set; }
        public string FIO { get; set; }
        public string DOLZNOST { get; set; }
        public string STAVKA { get; set; }
        public Nullable<int> ID { get; set; }
    
        public virtual USERS USERS { get; set; }
    }
}
