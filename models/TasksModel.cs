using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstApi.models
{
  public class TasksModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
  }
}