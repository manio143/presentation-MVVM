using System.Collections.Generic;
using System.Linq;
using MVVM_Pattern.Models;

namespace MVVM_Pattern.ViewModels
{
    public class UserHometownViewModel
    {
        public UserHometownViewModel(List<Person> people)
        {
            var distinctHometowns = people.Select(p => p.Hometown).Distinct();
            UserHometowns = new Dictionary<string, int>();
            foreach (var hometown in distinctHometowns)
                UserHometowns.Add(hometown, people.Count(p => p.Hometown == hometown));
        }

        public Dictionary<string, int> UserHometowns { get; } 
    }
}
