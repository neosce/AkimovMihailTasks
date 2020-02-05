let btn = document.querySelector("#btn");

function remover()
{
    let text = document.querySelector("#Text1").value;
    var words = text.split(' ');
    var sep = ["?", "!", ":", ";", ",", "."];
    var res = [];

    for (let i = 0; i < words.length; i++)
    {
        if (words[i].indexOf(sep) == -1)
        {
            var word = words[i].split('');
            res += wordsSplit(word).join('');
            res += " ";
        } 
    }
    document.querySelector("#Text1").value = res;
}

function wordsSplit(word)
{
    var remove = [];
    remove = remove.concat(word);

    for (let i = 0; i < word.length; i++)
    {
        for (let j = i + 1; j < word.length; j++)
        {
            if (word[i] == word[j] && word[i] != undefined && word[j] != undefined)
            {
                if (word[i] != undefined) 
                    delete word[i];
                if (word[j] != undefined)
                    delete word[j];
            }
        }
    }
    word = deleteEmpty(word);
    return word;
}

function deleteEmpty(word)
{
    let emptyDel = [];
    emptyDel = word.filter(element => element !== undefined);
    return emptyDel;
}

btn.onclick = remover;