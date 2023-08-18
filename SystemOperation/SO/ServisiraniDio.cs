﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.Exceptions;

namespace SystemOperation.SO
{
    public class ServisiraniDioSO : SystemOperationBase
    {
        private readonly RotablePartsLog rotablePartsLog;
        public ServisiraniDioSO(RotablePartsLog rotablePartsLog)
        {
            this.rotablePartsLog = rotablePartsLog;
        }
        public RotablePartsLog Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                rotablePartsLog.RotableParts = (RotableParts)repository.SearchOne(rotablePartsLog.RotableParts);
                ((RotablePartsService)rotablePartsLog.RotablePartsSubClass).RotableParts.ID_RotableParts = rotablePartsLog.RotableParts.ID_RotableParts;
                rotablePartsLog.RotablePartsSubClass = (RotablePartsService)repository.SearchOne((RotablePartsService)rotablePartsLog.RotablePartsSubClass);
                if (rotablePartsLog.RotablePartsSubClass == null)
                    Result = null;
                else
                    Result = rotablePartsLog;
           }
            catch (Exception)
            {
                throw new SystemOperationException("Sistem ne može da pronađe servisirane dio aviona!");
            }
        }
    }
}
