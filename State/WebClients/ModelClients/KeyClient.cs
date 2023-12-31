﻿using ContractManagment.Client.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ContractManagment.Client.State.WebClients.ModelClients
{
    public class KeyClient : IReadWriteClient<KeyModel>
    {
        private IWebClient _webClient;

        public KeyClient(IWebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task Create(KeyModel obj)
        {
            await _webClient.Client.PostAsJsonAsync("/Key", obj);
        }

        public async Task DeleteById(int id)
        {
            await _webClient.Client.DeleteAsync($"/Key/{id}");
        }

        public async Task<List<KeyModel>> GetAll()
        {
            List<KeyModel> list = await _webClient.Client.GetFromJsonAsync<List<KeyModel>>("/Key");
            return list;
        }

        public Task<KeyModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(KeyModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
