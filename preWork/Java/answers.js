//Setting and Swapping
var myNumber = 42;
var myName = 'Jeremy';
myName = myNumber;
myNumber = 'Jeremy';

//Print -52 to 1066
for(var printNum = -52; printNum < 1007; printNum++)
	{
	console.log(printNum);
	}

//Don't Worry, Be Happy
function beCheerful()
	{
	console.log('good morning!');
	}
for(var beNum = 0; beNum < 99; beNum++)
	{
	beCheerful();
	}

//Multiples of Three - but Not All
for(var threeNum = -300; threeNum < 1; threeNum += 3)
	{
	if (threeNum == -3 || threeNum == -6)
		{
		continue;
		}
	console.log(threeNum);
	}

//Printing Integers with While
var whileInts = 2000;
while (whileInts < 5281)
	{
		console.log(whileInts);
		whileInts = whileInts + 1;
	}

//You Say It's Your Bithday
function birthdayTest(month,day)
{
	if ((month == 11 && day == 3)||(month == 3 && day == 11))
	{
	console.log("How did you know?");
	}
	else
	{
	console.log("Just another day...");
	}
}

//Leap Year
function leapYear(year)
{
	if (year % 4 == 0 && (year % 100 !== 0 || year % 400 == 0))
	{
	console.log(year " is a leap years!");
	}
	else
	{
	console.log(year " is not a leap year!");
	}
}

//Print and Count
var intCount = 0;
for(var fivers = 515; fivers < 4100; fivers +=5)
	{
		console.log(fivers);
		intCount +=1;
	}
console.log(intCount);

//Multiples of Six
var sixers = 6;
while(sixers < 60001)
	{
		console.log(sixers);
		sixers = sixers + 6;
	}

//Counting, the Dojo Way
for(var codingInts = 1; codingInts < 101; codingInts++)
{
	if(codingsInts % 10 = 0)
	{
		console.log("Coding Dojo");
	}
	else if(codingInts % 5  0)
	{
		console.log("Coding");
	}
	else
	{
		console.log(codingInts);
	}
}
//What Do You Know?
function incomingLog(incoming)
{
	console.log(incoming);
}

//Whoa, That Sucker's Huge...
var sum = 0;
for(var hugeNumber = -299999; hugeNumber < 300000; hugeNumber +=2)
{
	sum = sum + hugeNumber;
}
console.log(sum);
//shortcut
console.log(0);

//Countdown by Fours
var countdownFour = 2016;
while (countdownFour > 0)
	{
		console.log(countdownFour);
		countdownFour = countdownFour - 4;
	}

//Flexible Countdown
function flexCount(lowNum,highNum,mult)
{
	for(var flexy = highNum; flexy > lowNum; flexy-=mult)
	{
		console.log(flexy);
	}
}

//The Final Countdown
function finalCount(param1,param2,param3,param4)
{
	var paramz = param2;
	while(paramz > param3)
	{
		if(paramz = param4)
		{
			continue;
		}
		else if(paramz % param1 = 0)
		{
			console.log(paramz);
		}
		paramz--;
	}
}

//Countdown
var countArr = [];
function CountItDown(countNum)
{
	for(var tempCountNum = countNum; tempCountNum >= 0; tempCountNum--)
	{
		countArr.push(tempCountNum);
	}
	console.log(countArr);
	console.log(countArr.length);
}

//Print and Return
function printReturn(arr1,arr2)
{
	
}