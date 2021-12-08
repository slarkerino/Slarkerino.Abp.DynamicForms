$(function () {

    var l = abp.localization.getResource('DynamicForms');

    var service = slarkerino.abp.dynamicForms.answers.answer;
    var createModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Answers/Answer/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Answers/Answer/EditModal');

    var dataTable = $('#AnswerTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('AnswerDeletionConfirmationMessage', data.record.id);
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
                title: l('AnswerQuestionId'),
                data: "questionId"
            },
            {
                title: l('AnswerQuestionType'),
                data: "questionType"
            },
            {
                title: l('AnswerQuestionTitle'),
                data: "questionTitle"
            },
            {
                title: l('AnswerExtraProperties'),
                data: "extraProperties"
            },
            {
                title: l('AnswerResult'),
                data: "result"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewAnswerButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
