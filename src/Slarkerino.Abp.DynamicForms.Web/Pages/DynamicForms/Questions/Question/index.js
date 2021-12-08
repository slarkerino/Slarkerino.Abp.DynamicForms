$(function () {

    var l = abp.localization.getResource('DynamicForms');

    var service = slarkerino.abp.dynamicForms.questions.question;
    var createModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Questions/Question/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'DynamicForms/Questions/Question/EditModal');

    var dataTable = $('#QuestionTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('QuestionDeletionConfirmationMessage', data.record.id);
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
                title: l('QuestionTitle'),
                data: "title"
            },
            {
                title: l('QuestionExtraProperties'),
                data: "extraProperties"
            },
            {
                title: l('QuestionQuestionType'),
                data: "questionType"
            },
            {
                title: l('QuestionMinScore'),
                data: "minScore"
            },
            {
                title: l('QuestionMaxScore'),
                data: "maxScore"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewQuestionButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
