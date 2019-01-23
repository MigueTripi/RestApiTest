http://localhost:49180/api/Cotizacion/GetName/?aNumber=123
http://localhost:49180/api/Cotizacion/GetName


//1
var Employee = function(first, last, salary) {
  this.firstName = first;
  this.lastName = last;
  this.salary = salary;
}

Employee.prototype.increaseSalary = function() {
  this.salary += 1000;
};

Employee.prototype.details = function() {
  console.log(this);
};

var newEmployee = new Employee('Migue', 'Tripi', 100);
newEmployee.increaseSalary();
newEmployee.details();


//2
function MultiplyBy(x) {
  return (y) => {
    return (z) => {
      return x * y * z;
    };
  };
}

console.log(MultiplyBy(2)(3)(4)) 
console.log(MultiplyBy(4)(3)(4)) 

//3
function Longest_Country_Name(countries){
  return countries.reduce(function (a, b) { return a.length > b.length ? a : b; });
}
console.log(Longest_Country_Name(["Australia", "Germany", "United States of America"]));


//4

removecolor = function()
{
  
var select=document.getElementById('colorSelect');

  for (i=0;i<select.length;  i++) {
   if (select.options[i].value == select.value) {
     select.remove(i);
   }
  }
}


//5


insert_Row = function()
{
  var table = document.getElementById("sampleTable");

  var rowCounts = table.getElementsByTagName("tr").length;
  var row = table.insertRow(rowCounts);

  var cell1 = row.insertCell(0);
  var cell2 = row.insertCell(1);

  cell1.innerHTML = "NewCell 1";
  cell2.innerHTML = "NewCell 2";
}
