using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TodoApi.Models
{
    public class Album
    {
        public long Id { get; set; }
    
        public string Name { get; set; }
        
        public string Artist{ get; set; }
        
        
    }
}