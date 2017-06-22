/*
	JavaScript 6th Edition
	Chapter 7
	Hands-on Project 7-5

	Author: Todd Pidgeon
	Date:   04/06/2016
*/

"use strict";

var delivInfo = {};
var delivSummary = document.getElementById("deliverTo");
var foodInfo = {};
var foodSummary = document.getElementById("order");

function processDeliveryInfo()
{
	var prop;
	delivInfo.name = document.getElementById("nameinput").value;
	delivInfo.addr = document.getElementById("addrinput").value;
	delivInfo.city = document.getElementById("cityinput").value;
	delivInfo.email = document.getElementById("emailinput").value;
	delivInfo.phone = document.getElementById("phoneinput").value;
	
	for(prop in delivInfo)
	{
		delivSummary.innerHTML += "<p>" + delivInfo[prop] + "</p>";
	}
}

function previewOrder()
{
	processDeliveryInfo();
	processFood();
	document.getElementsByTagName("section")[0].style.display = "block";
	document.getElementById("deliverTo").style.display = "block";
}

function processFood()
{
	var prop;
	var crustOpt = document.getElementsByName("crust");
	var toppings = 0;
	var toppingBoxes = document.getElementsByName("toppings");
	var instr = document.getElementById("instructions");
	
	if (crustOpt[0].checked)
	{
		foodInfo.crust = crustOpt[0].value;
	}
	else
	{
		foodInfo.crust = crustOpt[1].value;
	}
	
	foodInfo.size = document.getElementById("size").value;
	
	for (var x = 0; x < toppingBoxes.length; x++)
	{
		if (toppingBoxes[x].checked)
		{
			toppings++
			foodInfo["topping" + toppings] = toppingBoxes[x].value;
		}
	}
	
	if (instr != "")
	{
		foodInfo.instructions = instr.value;
	}
	else
	{
		foodInfo.instructions = "";
	}
	
	foodSummary.innerHTML += "<p><span>Crust</span>: " + foodInfo.crust + "</p>";
	foodSummary.innerHTML += "<p><span>Size</span>: " + foodInfo.size + "</p>";
	foodSummary.innerHTML += "<p><span>Topping(s)</span>: " + "</p>";
	foodSummary.innerHTML += "<ul>";
	
	for (var i = 1; i < 6; i++) 
	{
		if (foodInfo["topping" + i]) 
		{
			foodSummary.innerHTML += "<li>" + foodInfo["topping" + i] + "</li>";
		}
	}
	
	foodSummary.innerHTML += "</ul>";
	foodSummary.innerHTML += "<p><span>Instructions</span>: " + foodInfo.instructions;
	document.getElementById("order").style.display = "block";
}

function createEventListeners() 
{
	var previewbutton = document.getElementById("previewBtn");
	
	if (previewbutton.addEventListener) 
	{
		previewbutton.addEventListener("click", previewOrder, false);
	} 
	else if (previewbutton.attachEvent) 
	{
		previewbutton.attachEvent("onclick", previewOrder);
	}
}
	
if (window.addEventListener) 
{
	window.addEventListener("load", createEventListeners, false);
} 
else if (window.attachEvent) 
{
	window.attachEvent("onload", createEventListeners);
}
	