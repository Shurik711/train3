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
    
    public partial class SKLAD
    {
        public int IDSK { get; set; }
        public string NAME { get; set; }
        public string KATEGORY { get; set; }
        public string PRICE { get; set; }
        public string KOLVO { get; set; }
        public Nullable<int> ID { get; set; }
    
        public virtual USERS USERS { get; set; }
    }
}
