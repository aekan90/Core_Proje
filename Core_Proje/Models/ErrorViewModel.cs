using System;

namespace Core_Proje.Models
{
    public class ErrorViewModel
    {
        // Hata View
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
