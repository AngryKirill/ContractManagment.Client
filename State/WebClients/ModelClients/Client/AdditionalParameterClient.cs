﻿using ContractManagment.Client.MVVM.Model.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagment.Client.State.WebClients.ModelClients.Client
{
    public class AdditionalParameterClient : IReadClient<AdditionalParameterModel>
    {
        public Task<List<AdditionalParameterModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AdditionalParameterModel> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
