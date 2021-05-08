function UpdateGlobalModifier(_this) {
    var currentModifier = parseInt($("#Modifiers_TotalXpModifier").val());
    var cookingFire = parseInt($(_this).find(":selected").val());
    $("#modifierDisplay").text(currentModifier + cookingFire + "% Skill XP Modifier");
}

function updateXp(this) {
    console.log("Not Implemented");
}

function updateLevel(this) {
    console.log("Not Implemented");
}

