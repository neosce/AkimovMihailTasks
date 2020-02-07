let time = 30;
var timeStop;
let pageNumNext = 0;

let btnStop = document.querySelector("#stop");
let btnStart = document.querySelector("#start");
let btnPrev = document.querySelector("#btn1");
let btnNext = document.querySelector("#btn2");

let pageArr = [" /Task_9/Task9_4", " /Task_9/Task9_4_1", " /Task_9/Task9_4_2"];

function getLocation()
{
    var exp = /\s/;

    for (let i = 0; i < pageArr.length; i++)
    {
        var result = pageArr[i].split(exp);
        pageArr[i] = window.location.origin.toString();

        for (let j = 0; j < result.length; j++)
        {
            pageArr[i] += result[j];
        }
    }
}

getLocation(); 

function timer()
{
    document.querySelector("#time").innerHTML = time--;

    timeStop = window.setTimeout(function () { timer() }, 1000);

    if (time < 0)
    {
        nextPage();
    }
}

timer();

function startTimer()
{
    if (!timeStop)
    {
        timer();
    }
}

function stopTimer()
{
    if (timeStop)
    {
        clearTimeout(timeStop);
        timeStop = null;
    }
}

function nextPage()
{
    for (let i = 0; i < pageArr.length; i++)
    {
        if (window.location.href == pageArr[i])
        {
            window.location.href = pageArr[i + 1];
        }
        else if (window.location.href == pageArr[2])
        {
            window.location.href = pageArr[0];
        }
    }
}

function prevPage()
{
    for (let i = 1; i < pageArr.length; i++)
    {
        if (window.location.href == pageArr[i])
        {
            window.location.href = pageArr[i - 1];
        }
        else if (window.location.href == pageArr[0])
        {
            alert("This is main page!");
            break;
        }
    }
}

btnStart.onclick = startTimer;
btnStop.onclick = stopTimer;

btnNext.onclick = nextPage;
btnPrev.onclick = prevPage;