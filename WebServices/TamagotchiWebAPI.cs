using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TamagotchiConsoleApp.DataTransferObjects;

namespace TamagotchiConsoleApp.WebServices
{
    public class TamagotchiWebAPI
    {
        private HttpClient client;
        private string baseUri;

        public TamagotchiWebAPI(string baseUri)
        {
            //Set client handler to support cookies!!
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new System.Net.CookieContainer();

            //Create client with the handler!
            this.client = new HttpClient(handler, true);
            this.baseUri = baseUri;
        }

        public async Task<PlayerDTO> LoginAsync(string email, string pass)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/login?email={email}&pass={pass}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    PlayerDTO p = JsonSerializer.Deserialize<PlayerDTO>(content, options);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<AnimalDTO> CreateAnimalAsync(string name)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/createAnimal?name={name}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO a = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public async Task<PlayerDTO> RegisterAsync(string firstName, string lastName, string email, DateTime birthDate, string username, string pswd)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/register?firstName={firstName}&lastName={lastName}&email={email}&dt={birthDate}&username={username}&password={pswd}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    PlayerDTO p = JsonSerializer.Deserialize<PlayerDTO>(content, options);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<List<ActivitiesHistoryDTO>> ActivitiesHistoryAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/ActivitiesHistory?id={id}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    List<ActivitiesHistoryDTO> o = JsonSerializer.Deserialize<List<ActivitiesHistoryDTO>>(content, options);
                    return o;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<AnimalDTO> ActiveAnimalAsync() 
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/activeAnimal");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO a = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<AnimalDTO> PastAnimalAsync(int AnimalID) 
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/getAnimalByID?id={AnimalID}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO a = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<List<AnimalDTO>> GetPlayerAnimalsAsync()
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/getPlayerAnimals");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    List<AnimalDTO> l = JsonSerializer.Deserialize<List<AnimalDTO>>(content, options);
                    return l;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<AnimalDTO> GetAnimalByIdAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/getAnimalByID?id={id}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO a = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<bool> CheckIfDeadAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/checkIfDead?id={id}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    bool b = JsonSerializer.Deserialize<bool>(content, options);
                    return b;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return true;
            }
        }
    }
}