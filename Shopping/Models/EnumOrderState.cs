﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public enum EnumOrderState
    {
        [Display(Name ="Onay Bekleniyor")]
        Bekleniyor,
        [Display(Name = "Sipariş Tamamlandı")]
        Tamamlandı,
        [Display(Name = "Paketlendi")]
        Paketlendi,
        [Display(Name = "Kargolandı")]
        Kargolandı,

    }
}