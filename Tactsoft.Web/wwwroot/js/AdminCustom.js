$(document).ready(function () {

  $('#example').DataTable();

  /*Enroll Medicine Start*/
  $('#medicineEnrollTable').DataTable({
    "columnDefs": [
      { "orderable": false, "targets": 3 }
    ]
  });
  /*Enroll Medicine End*/

  /*Employee Rgister Start*/
  $('#employeeRegiTable').DataTable();
  /*Employee Rgister End*/

  /*Student Table Export Start*/
  $('#exportStudentTable').DataTable({
    searching: false,
    paging: false,
    dom: 'Bfrtip',
    buttons: [
      'copy', 'csv', 'excel', 'pdf', 'print'
    ]
  });
  /*Student Table Export End*/



  /*--Multiple Step Form Start--*/
  $('.next').click(function () {
    $('#stepTwo').show(),
      $('#stepOne, #stepThree').hide();
  });
  /*--Multiple Step Form End--*/



});