using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedd.Utils {
	public class GuestHelper {
		public Guest GetGuest(string id) {
			var guest = GuestData.GetGuestList();
			return guest.FirstOrDefault(x => x.Id == id) ?? new Guest { };
		}
	}

	public class Guest {
		public string Id { get; set; }
		public List<string> GuestsNames { get; set; }
		public int TableNo { get; set; }
		public string OwnerName { get; set; }
	}

	public static class GuestData {
		public static List<Guest> GetGuestList() {
			var guests = new List<Guest> { };

			guests.Add(new Guest { Id = "M7NJ6D", OwnerName = "goga", GuestsNames = new List<string> { "giorgi da Tamar" }, TableNo = 17 });

			return guests;
		}
	}
}
