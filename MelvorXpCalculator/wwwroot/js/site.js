function UpdateGlobalModifier(_this) {
    var currentModifier = parseInt($("#Modifiers_TotalXpModifier").val());
    console.log(currentModifier);
    var modifier = parseInt(currentModifier);
    if ($(_this).is(":checked"))
        modifier = parseInt(currentModifier) + parseInt(_this.value);
    else
        modifier = $("#Modifiers_TotalXpModifier").val();
    $("#modifierDisplay").text(modifier + "% Skill XP Modifier");
}

function updateXp(_this) {
    console.log("Not Implemented");
}

function updateLevel(_this) {
    console.log("Not Implemented");
}

function calculateXp(_this) {
    var xp = calculateExperience(_this.value);
    $("#targetXp").val(xp);
    var difference = parseInt(targetXp) - parseInt(xp);
    $("#xpDifference").val(difference);
}

function calculateDifference(_this) {
    var currentXp = $("#xp").val();
    var targetXp = _this.value;
    var difference = parseInt(targetXp) - parseInt(currentXp);
    $("#xpDifference").val(difference);
    $("#targetLevel").val(calculateLevel(targetXp));
}

function calculateExperience(level) {
    var total = 0;
    for (var i = 1; i < level; i++)
    {
        total += Math.floor(i + 300 * Math.pow(2, i / 7.0));
    }
    return Math.floor(total / 4);
}

function calculateLevel(experience) {
    var index;
    for (index = 0; index < 120; index++) {
        if (calculateExperience(index + 1) > experience)
            break;
    }
    return index;
}

