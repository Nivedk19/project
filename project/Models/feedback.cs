using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.schema;



public class feedback
{
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

	public int ID { get; set; }
	public int? Answer { get; set; }
	[StringLength(500)]
	public string Comment { get; set; }
	[StringLength(100)]
	public string FullName { get; set; }
	[StringLength(255)]
	public string Email { get; set; }
   
}





	
   

