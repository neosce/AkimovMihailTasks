let s1 = document.querySelector("#slct1");
let s2 = document.querySelector("#slct2");
let s3 = document.querySelector("#slct3");

let btn1 = document.querySelector("#btn1");
let btn2 = document.querySelector("#btn2");
let btn3 = document.querySelector("#btn3");
let btn4 = document.querySelector("#btn4");
let btnAll1 = document.querySelector("#btnAll1");
let btnAll2 = document.querySelector("#btnAll2");
let btnAll3 = document.querySelector("#btnAll3");
let btnAll4 = document.querySelector("#btnAll4");

let optionArr = ["Option1", "Option2", "Option3", "Option4", "Option5"];

// Dynamic add option
function populate()
{
    for (let i = 0; i < optionArr.length; i++)
    {
        let newOption = new Option(optionArr[i], optionArr[i]);
        s1.append(newOption);
    }
    // Select new add option for start
    s1.options[0].selected = true;
    s1.options[1].selected = true;
    s1.options[2].selected = true;
}

populate();

// Select 1 to Select 2
function optionRight()
{
    optionAdd(s1, s2);
    sortOption(s2);
}

function optionLeft()
{
    optionAdd(s2, s1);
    sortOption(s1);
}

function optionRightAll()
{
    optionAll(s1, s2);
    sortOption(s2);
}

function optionLeftAll()
{
    optionAll(s2, s1);
    sortOption(s1);
}

// Select 2 to select 3 

function optionRight3()
{
    optionAdd(s2, s3);
    sortOption(s3);
}

function optionLeft3()
{
    optionAdd(s3, s2);
    sortOption(s2);
}

function optionRightAll3()
{
    optionAll(s2, s3);
    sortOption(s3);
}

function optionLeftAll4()
{
    optionAll(s3, s2);
    sortOption(s2);
}

// Select function

function optionAdd(selectedA, selectedB)
{
    let selected = Array.from(selectedA.options)
        .filter(option => option.selected)
        .map(option => option.value);

    if (selected.length == 0)
    {
        alert("Choose your option!");
    }
    else
    {
        for (let i = 0; i < selectedA.length; i++)
        {
            for (let j = 0; j < selected.length; j++)
            {
                if (selectedA[i].value == selected[j])
                {
                    let newOption = new Option(selected[j], selected[j]);
                    selectedB.append(newOption);
                    selectedA.options[i] = null;
                }
            }

        }
    }
}

function optionAll(selectedA, selectedB)
{
    let optionSelect = Array.from(selectedA.options)
        .map(option => option.value);

    if (optionSelect == 0)
    {
        alert("Option empty!");
    }
    else
    {
        for (let i = optionSelect.length - 1; i >= 0; i--)
        {
            let newOption = new Option(optionSelect[i], optionSelect[i]);
            selectedB.append(newOption);
            selectedA.options[i] = null;
        }
    }
}

function sortOption(selected)
{
    var arr = Array.from(selected.children).sort((x, y) => {
        return x.text.localeCompare(y.text);
    });
    arr.forEach(x => selected.appendChild(x));
}

// Block button call function

// 1 - 2 block 
btn1.onclick = optionRight;
btn2.onclick = optionLeft;
btnAll1.onclick = optionRightAll;
btnAll2.onclick = optionLeftAll;
// 2 - 3 block 
btn3.onclick = optionRight3;
btn4.onclick = optionLeft3;
btnAll3.onclick = optionRightAll3;
btnAll4.onclick = optionLeftAll4;
