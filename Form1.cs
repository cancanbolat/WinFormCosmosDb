using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCosmosDb.Models;
using static WinFormCosmosDb.Models.Family;

namespace WinFormCosmosDb
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Address[] Address { get; set; }
        List<Address> addresses = new List<Address>();

        private string EndpointUrl = Configuration.Conf.EndpointUrl;
        private string PrimaryKey = Configuration.Conf.PrimaryKey;

        private CosmosClient cosmosClient;
        private Database database;
        private Microsoft.Azure.Cosmos.Container container;

        private string databaseId = "FamilyDatabase";
        private string containerId = "AddressContainer";


        public Form1()
        {
            InitializeComponent();
        }

        private void metroButtonAddFamilyPage_Click(object sender, EventArgs e)
        {

        }

        private void AddAddressPetParentBtn_Click(object sender, EventArgs e)
        {

        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            this.cosmosClient = new CosmosClient(EndpointUrl, PrimaryKey);
            await QueryItemsAsync();
        }

        //Create Database
        private async Task CreateDatabaseAsync()
        {
            this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
        }

        //Cerate Container
        private async Task CreateContainerAsync()
        {
            this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "/Country");
        }

        //Create an item
        private async Task AddItemsToContainerAsync()
        {
            Address = new Address[]
            {
                new Address { State = "WA", Country = "King", City = "Seattle" },
                new Address { State = "TR", Country = "Turkey", City = "Tarsus" }
            };
            

            try
            {
                ItemResponse<Address> addressResponse
                    = await this.container.CreateItemAsync<Address>(Address, new PartitionKey(Address.Select(x => x.Country).ToString());
            }
            catch (CosmosException ex) when (ex.StatusCode == HttpStatusCode.Conflict)
            {
                Console.WriteLine("Item in database with id: {0} already exists\n", address.Country);
            }
        }

        private async Task QueryItemsAsync()
        {
            await CreateDatabaseAsync();
            await CreateContainerAsync();
            await AddItemsToContainerAsync();

            var addressQuery = "SELECT * FROM address";
            //var petsQuery = "SELECT * FROM Pet";
            //var parentsQuery = "SELECT * FROM Parent";

            QueryDefinition addressesQueryDefinition = new QueryDefinition(addressQuery);
            //QueryDefinition petsQueryDefinition = new QueryDefinition(petsQuery);
            //QueryDefinition parentsQueryDefinition = new QueryDefinition(parentsQuery);

            FeedIterator<Address> addressIterator = this.container.GetItemQueryIterator<Address>(addressesQueryDefinition);
            //FeedIterator<Pet> petsIterator = this.container.GetItemQueryIterator<Pet>(petsQueryDefinition);
            //FeedIterator<Parent> parentsIterator = this.container.GetItemQueryIterator<Parent>(parentsQueryDefinition);

            //List<Pet> pets = new List<Pet>();
            //List<Parent> parents = new List<Parent>();

            while (addressIterator.HasMoreResults)
            {
                FeedResponse<Address> addressResultSet = await addressIterator.ReadNextAsync();
                //FeedResponse<Pet> petsResultSet = await petsIterator.ReadNextAsync();
                //FeedResponse<Parent> parentsResultSet = await parentsIterator.ReadNextAsync();

                foreach (Address address in addressResultSet)
                    addresses.Add(address);

                //foreach (Pet pet in petsResultSet)
                //    pets.Add(pet);

                //foreach (Parent parent in parentsResultSet)
                //    parents.Add(parent);
            }

            dataGridViewAddresses.DataSource = addresses;
            //dataGridViewPets.DataSource = pets;
            //dataGridViewParents.DataSource = parents;
        }
    }
}
