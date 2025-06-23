//define a Planet class
class Planet {
  constructor(name, inner, diameter, color) {
    this.name = name;
    this.inner = inner;
    this.diameter = diameter;
    this.color = color;
  }
  }

//VARIABLES
  //define a variable to track which planet the user is on.
  let index = 0;

  //access the <p> that displays the planet number
  let indexDisplay = document.getElementById('indexDisplay');

  //access the <h2> that displays the planet name
  let planetNameDisplay = document.getElementById('planetName');

  //access the <p> that displays inner planet status
  let innerPlanetDisplay = document.getElementById('innerPlanet');

 //access the <div> that represents the planet
 let planetCircle = document.getElementById('planetCircle');

 //access the prev button
 let prevButton = document.getElementById('prev');

  //access the next button
  let nextButton = document.getElementById('next');



  //array of Planets
 const planets = [
   new Planet("Mercury", true, 3031.9, "#696969"),
   new Planet("Venus", true, 7520.8, "#b89165"),
   new Planet("Earth", true, 7917.5, "#5a5b86"),
   new Planet("Mars", true, 4212.3, "#df8c4e"),
   new Planet("Jupiter", false, 86881, "#f6a049"),
   new Planet("Saturn", false, 72367, "#dcd3a1"),
   new Planet("Uranus", false, 31518, "#b4d9df"),
   new Planet("Neptune", false, 30599, "#456eff")
 ];
//log each planet's name to the console
  for(const planet of planets) {
  //using const ... of gives the *element instead of the index
    //we could also use planets[planet].name
  console.log(planet.name);
  }

//FUNCTIONS

//function to return the average of the diameters in an array of Planets
function averageDiameter(planets) {
//initialize a placeholder int to hold the sum of the diameters
let sum = 0;

//loop through the Planet array passed in by the user
for (const planet of planets) {
//add the diameter of each Planet to the sum
sum += planet.diameter;
}

//calculate and return the average of the diameters using sum.
return sum / planets.length;
}
function updatePlanetDisplay() {
    //disable the prev button if index is 0
     if (index === 0) {
       prevButton.disabled = true;
     } else {
       prevButton.disabled = false;
     }
     //disable the next button if index is greater than the number of planets
     if (index === planets.length - 1) {
       nextButton.disabled = true;
     } else {
       nextButton.disabled = false;
     }


    //access the current planet using index
    let planet = planets[index];

     //define the planet's diameter / 100
     const size = planet.diameter / 100;

    //update the h2 to the planet's name
    planetNameDisplay.textContent = planet.name;

    //update the p to the planet's inner planet status
    innerPlanetDisplay.textContent = planet.inner ? "Inner planet" : "Outer planet";

    //update the div background to the planet's color
    planetCircle.style.backgroundColor = planet.color;

    //update the div height/width to size
    planetCircle.style.width = size + "px";
    planetCircle.style.height = size + "px";

}
//increment or decrement the index declared above
    //updateIndex takes in a bool upOrDown (true = up/increment, false = down/decrement)
function updateIndex(upOrDown) {
if (upOrDown) {
index++;
} else {
index--;
}

//update the <p> element
indexDisplay.textContent = index;

//call updatePlanetDisplay
updatePlanetDisplay()
}


//call updatePlanetDisplay to prevent the prev button from being enabled at launch
updatePlanetDisplay();
