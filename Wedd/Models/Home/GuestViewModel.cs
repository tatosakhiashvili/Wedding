using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedd.Utils;

namespace Wedd.Models.Home {
	public class GuestViewModel {
		public string Id { get; set; }
		public List<string> Names { get; set; }
		public string OwnerName { get; set; }
		public string GuestName { get; set; }
		public int TableNo { get; set; }
		public string RandomImage { get; set; }

		public static implicit operator GuestViewModel(Guest guest) {

			guest.GuestsNames = guest.GuestsNames ?? new List<string> { };

			var response = new GuestViewModel {
				Id = guest.Id,
				Names = guest.GuestsNames,
				TableNo = guest.TableNo,
				OwnerName = guest.OwnerName,
				GuestName = guest.GuestsNames.FirstOrDefault(),
				RandomImage = Utils.Utils.GetRandomImage()
			};

			return response;
		}
	}
}
