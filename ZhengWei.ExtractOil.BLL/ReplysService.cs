﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZhengWei.ExtractOil.IBLL;
using ZhengWeil.ExtractOil.Model;

namespace ZhengWei.ExtractOil.BLL
{
   public class ReplysService:BaseService<Replys>,IReplysService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DbSession.ReplysDal;
        }
    }
}
