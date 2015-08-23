function solve() {
  return function (selector) {
    var $selectedList = $(selector).hide(),
        options = $selectedList.find('option'),
        $divContainer = $('<div>')
        .addClass('dropdown-list')
        .append($selectedList),

        $currentSelection = $('<div>')
        .addClass('current')
        .attr('data-value', '')
        .text('Select value'),

        $divOptionsContainer = $('<div>')
        .addClass('options-container')
        .css({
          'position': 'absolute',
          'display': 'none'
        }),
        i,
        len;

    $currentSelection.on('click', function () {
      var $container = $('.options-container');

      $container.css('display', 'inline-block');
    });

    $divOptionsContainer.on('click', function (ev) {
      var $clicked = $(ev.target),
      $divToDisplay = $('.current'),
          $container = $(this).css('display', 'none');

      $divToDisplay.text($clicked.html());
      $selectedList.val($clicked.attr('data-value'));
    });

    for (i = 1, len = options.length; i <= len; i += 1) {
      var newOpt = $('<div>')
          .addClass('dropdown-item')
          .attr('data-value', $(options[i]).val())
          .attr('data-index', i - 1)
          .text($(options[i]).text());

      $divOptionsContainer.append(newOpt);
    }

    $divContainer.appendTo('body');
    $currentSelection.appendTo($divContainer);
    $divOptionsContainer.appendTo($divContainer);
  };
}

module.exports = solve;