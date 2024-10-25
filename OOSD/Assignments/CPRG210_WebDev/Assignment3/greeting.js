// greeting.js

const greetings = [
    "Hello!",
    "Hi there!",
    "Greetings!",
    "Howdy!",
    "Hey!",
    "Good day!",
    "What's up?"
];

function getRandomGreeting() {
    const index = Math.floor(Math.random() * greetings.length);
    return greetings[index];
}

module.exports = getRandomGreeting;
