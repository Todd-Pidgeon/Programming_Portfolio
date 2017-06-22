/*
	JavaScript 6th Edition
	Chapter 7
	Hands-on Project 7-4

	Author: Todd Pidgeon
	Date:   04/06/2016
*/

"use strict";

var delivInfo = {};
var delivSummary = document.getElementById("deliverTo");

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
	document.getElementsByTagName("section")[0].style.display = "block";
	document.getElementById("deliverTo").style.display = "block";
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
	