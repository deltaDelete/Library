using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Library.Models;
using PZ17;

namespace Library.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<Client> _clients;

    public ObservableCollection<Client> Clients {
        get => _clients;
        set => SetField(ref _clients, value);
    }

    public MainWindowViewModel()
    {
        GetDataFromDb().GetAwaiter().GetResult();
    }

    private async Task GetDataFromDb()
    {
        var db = new Database();
        var clients = db.GetAsync<Client>();
        await using var enumerator = clients.GetAsyncEnumerator();
        var list = new List<Client>(); 
        while (await enumerator.MoveNextAsync())
        {
            var client = enumerator.Current;
            list.Add(client);
        }

        list.ForEach(it => it.Gender = db.GetById<Gender>(it.GenderId));
        
        Clients = new(list);
    }
}