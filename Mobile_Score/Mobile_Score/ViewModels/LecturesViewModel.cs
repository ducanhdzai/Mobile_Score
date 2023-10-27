using Mobile_Score.Models;
using Mobile_Score.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile_Score.ViewModels
{
    public class LecturesViewModel : BaseViewModel
    {

        private readonly IServices<PagingItem<Lectures>, string> _services;
        private PagingItem<Lectures> _lectures;
        public PagingItem<Lectures> Lectures
        {
            get { return _lectures; }
            set { SetProperty(ref _lectures, value); }
        }
        public LecturesViewModel(IServices<PagingItem<Lectures>, string> services)
        {
            _services = services;
        }
        public LecturesViewModel()
        {
            _services = DependencyService.Get<IServices<PagingItem<Lectures>, string>>();
        }
        public async Task<PagingItem<Lectures>> GetList()
        {
            Lectures = await _services.GetPagingData("Lecturers/GetAllNotDeletedAsync?idTrainingFacility=16811bfb-dc11-4f3e-b3c7-0f22ad823dad");
            return Lectures;
        }
        // 
       public async Task<PagingItem<Lectures>> GetList(string url)
        {
            Lectures = await _services.GetPagingData(url);
            return Lectures;
        }
    }
}
