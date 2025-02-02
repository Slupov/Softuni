function censorData(sentences) {
    let namePattern = /(\*[A-Z][a-zA-Z]*)(?= |\t|$)/g;
    let phonePattern = /(\+[0-9-]{10})(?= |\t|$)/g;
    let idPattern = /(![0-9a-zA-Z]+)(?= |\t|$)/g;
    let basePattern = /(_[0-9a-zA-Z]+)(?= |\t|$)/g;

    for(let s of sentences){
        s = s.replace(namePattern, m => '|'.repeat((m.length)));
        s = s.replace(phonePattern, m => '|'.repeat((m.length)));
        s = s.replace(idPattern, m => '|'.repeat((m.length)));
        s = s.replace(basePattern, m => '|'.repeat((m.length)));

        console.log(s);
    }
}

censorData([
    'Agent *Ivankov was in the room when it all happened.',
    'The person in the room was heavily armed.',
    'Agent *Ivankov had to act quick in order.',
    'He picked up his phone and called some unknown number.',
    'I think it was +555-49-796',
    "I can't really remember...",
    'He said something about "finishing work" with subject !2491a23BVB34Q and retu+555-49-796 rning to Base _Aurora21',
    'Then after that he disappeared *Pesho from my sight.*Pesho',
    'As if he vanished in the shadows.',
    'A moment, shorter than a second, later, I saw the person flying off the top floor.',
    "I really don't know what happened there.",
    'This is all I saw, that night.',
    'I cannot explain it myself...',
]);
