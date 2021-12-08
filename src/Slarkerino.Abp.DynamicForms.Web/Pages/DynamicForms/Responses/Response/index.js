$(function () {

    var l = abp.localization.getResource('DynamicForms');

    var service = slarkerino.abp.dynamicForms.responses.response;
    var createModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Responses/Response/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Responses/Response/EditModal');

    var dataTable = $('#ResponseTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('ResponseDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('ResponseSequence'),
                data: "sequence"
            },
            {
                title: l('ResponseStartTime'),
                data: "startTime"
            },
            {
                title: l('ResponseEndTime'),
                data: "endTime"
            },
            {
                title: l('ResponseSource'),
                data: "source"
            },
            {
                title: l('ResponseProjectId'),
                data: "projectId"
            },
            {
                title: l('ResponseAnswers'),
                data: "answers"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewResponseButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
