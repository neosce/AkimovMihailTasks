const content = document.querySelector(".contenthover");
const left = document.querySelector(".left");
const right = document.querySelector(".right");

// left
left.addEventListener('mouseenter', () =>
{
    content.classList.add('hover-left');
})

left.addEventListener('mouseleave', () =>
{
    content.classList.remove('hover-left');
})

// right
right.addEventListener('mouseenter', () =>
{
    content.classList.add('hover-right');
})

right.addEventListener('mouseleave', () =>
{
    content.classList.remove('hover-right');
})