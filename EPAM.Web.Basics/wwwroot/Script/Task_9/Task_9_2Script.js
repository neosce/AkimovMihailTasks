let btn = document.querySelector("#btn");

function Calculate()
{
    let text = document.querySelector("#Text").value;
    let res = 0;
    let math = [];
    let stringMath = /\-?\d+(\.\d+)?|([\+\-\*\/\=]){1}/g;

    math = text.match(stringMath);

    if (parseFloat(math[0]))
    {
        res += math[0] * 1;
    }

    for (let i = 0; i < math.length; i++)
    {
        switch (math[i])
        {
            case "+":
                res += math[i + 1] * 1;
                break;
            case "-":
                res -= math[i + 1] * 1;
                break;
            case "*":
                res *= math[i + 1] * 1;
                break;
            case "/":
                res /= math[i + 1] * 1;
                break;
            default:
                break;
        }
    }

    document.querySelector("#Text").value = text += res.toFixed(2);

}

btn.onclick = Calculate;