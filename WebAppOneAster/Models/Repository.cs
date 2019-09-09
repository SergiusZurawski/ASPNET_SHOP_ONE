using System;
using System.Collections.Generic;

namespace WebAppOneAster.Models
{
    public static class Repository
    { 
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

    }
}